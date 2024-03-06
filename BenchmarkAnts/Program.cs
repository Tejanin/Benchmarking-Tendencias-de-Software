using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkAnts
{
    [MemoryDiagnoser]
    public class Benchmarking
    {
        string AntStampede = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";

        [Benchmark(Baseline = true)]
        public void BenchmarkOfCountAntsBefore()
        {
            var instance = new AntsMethods();
            string input = string.Concat(Enumerable.Repeat(AntStampede, 10));
            instance.CountAntsBefore(input);
        }

        [Benchmark]
        public void BenchmarkOfCountAntsAfter()
        {
            var instance = new AntsMethods();
            string input = string.Concat(Enumerable.Repeat(AntStampede, 10));
            instance.CountAntsAfter(input);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {

            var summary = BenchmarkRunner.Run<Benchmarking>();
        }
    }
}
