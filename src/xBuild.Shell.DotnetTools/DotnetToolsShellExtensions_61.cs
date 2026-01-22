using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command MaradaUtils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"marada.utils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Myai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Moltoxyzcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"moltoxyzcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mailmcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mailmcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MarkdownsharpNet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markdownsharp.net {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Migrationtesttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"migrationtesttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetuWorkerservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metu.workerservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetigatorNumbersystemMas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metigator.numbersystem.mas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mantanimus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mantanimus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command M3utool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"m3utool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PicoMcpMail(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pico-mcp-mail {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NmTestMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nm.test.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sitetomarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sitetomarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Teemd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"teemd5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PaketSequelmed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"paket.sequelmed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"n.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WolfishMaia(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wolfish.maia {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XuyangTestMcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xuyang.test.mcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Patlitetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"patlitetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WhaleTui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"whale.tui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rtj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rtj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Numan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"numan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sobertools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sobertools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Optiscaffold(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"optiscaffold {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xcodetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xcodetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetulidTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netulid.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stardeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stardeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sugartool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sugartool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Textrudecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"textrudecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OptimoTest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"optimo.test {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Obfpdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"obfpdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PatSubscriberTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pat.subscriber.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Putool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"putool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PraalineScaffolder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"praaline.scaffolder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TicklesTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tickles.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RapidfireRfc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rapidfire-rfc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Quant(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"quant {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trashx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trashx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rextoyrobot(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rextoyrobot {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShockzWol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shockz.wol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Robotranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"robotranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command T4tools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"t4tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wminfra01(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wminfra-01 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Readwrite(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"readwrite {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Test6(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"test6 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Resxsorter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resxsorter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zpatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zpatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Today(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"today {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Samuel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samuel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trimerge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trimerge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Skript(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skript {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Solforge(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solforge {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Starrailtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"starrailtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}