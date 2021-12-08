using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using TestGeneratorLib.DataStructure;

namespace TestGeneratorLib.TestGenerator
{
    public class TestGenerator
    {
        protected readonly TestsGeneratorConfig config;

        public async Task Generate()
        {
            DataflowLinkOptions linkOptions = new DataflowLinkOptions
            {
                PropagateCompletion = true
            };
            ExecutionDataflowBlockOptions readOptions = new ExecutionDataflowBlockOptions
            {
                MaxDegreeOfParallelism = config.ReadThreadCount
            };
            ExecutionDataflowBlockOptions writeOptions = new ExecutionDataflowBlockOptions
            {
                MaxDegreeOfParallelism = config.WriteThreadCount
            };
            ExecutionDataflowBlockOptions processOptions = new ExecutionDataflowBlockOptions
            {
                MaxDegreeOfParallelism = config.ProcessThreadCount
            };

            var readTransform = new TransformBlock<string, Task<string>>((readPath) => config.Reader.ReadTextAsync(readPath), readOptions);
            var sourceToTestfileTransform = new TransformManyBlock<Task<string>, PathFile>((readSourceTask) => config.TemplateGenerator.Generate(readSourceTask.Result), processOptions);
            var writeAction = new ActionBlock<PathFile>((pathTextPair) => config.Writer.WriteTextAsync(pathTextPair).Wait(), writeOptions);

            readTransform.LinkTo(sourceToTestfileTransform, linkOptions);
            sourceToTestfileTransform.LinkTo(writeAction, linkOptions);

            foreach (string readPath in config.ReadPaths)
            {
                await readTransform.SendAsync(readPath);
            }

            readTransform.Complete();
            await writeAction.Completion;
        }

        public TestGenerator(TestsGeneratorConfig config)
        {
            this.config = config ?? throw new ArgumentException("Config shouldn't be null");
        }
    }
}
