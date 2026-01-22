using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T MaradaUtils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"marada.utils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Myai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Moltoxyzcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"moltoxyzcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mailmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mailmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MarkdownsharpNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markdownsharp.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Migrationtesttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"migrationtesttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetuWorkerservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metu.workerservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetigatorNumbersystemMas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metigator.numbersystem.mas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mantanimus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mantanimus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T M3utool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"m3utool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PicoMcpMail(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pico-mcp-mail {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NmTestMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nm.test.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sitetomarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sitetomarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Teemd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"teemd5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PaketSequelmed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"paket.sequelmed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"n.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WolfishMaia(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wolfish.maia {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XuyangTestMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xuyang.test.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Patlitetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"patlitetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WhaleTui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"whale.tui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rtj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rtj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Numan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"numan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sobertools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sobertools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Optiscaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"optiscaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xcodetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xcodetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetulidTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netulid.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stardeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stardeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sugartool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sugartool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Textrudecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"textrudecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OptimoTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"optimo.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Obfpdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"obfpdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PatSubscriberTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pat.subscriber.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Putool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"putool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PraalineScaffolder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"praaline.scaffolder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TicklesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tickles.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RapidfireRfc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rapidfire-rfc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Quant(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"quant {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trashx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trashx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rextoyrobot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rextoyrobot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShockzWol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shockz.wol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Robotranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"robotranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T T4tools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"t4tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wminfra01(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wminfra-01 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Readwrite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"readwrite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Test6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"test6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Resxsorter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resxsorter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zpatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zpatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Today(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"today {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Samuel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samuel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trimerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trimerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Skript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Solforge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solforge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Starrailtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"starrailtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}