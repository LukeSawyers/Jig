using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command EquadratLicensingCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"equadrat.licensing.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OcelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ocel-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HitrefreshScheduleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hitrefresh.schedule-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PotToCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pot_to_csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZeroLazCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zero.laz.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ThelairCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thelair.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetCodeSqlconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"net.code.sqlconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JsonpathCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jsonpath-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitcontrolcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitcontrolcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotsefClippy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotsef-clippy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TricepCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tricep.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Modshardchecksum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"modshardchecksum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"generator_cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MonolithCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"monolith-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HtmlFormsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"html.forms.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GrantthomasCrudCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"grantthomas.crud.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTextEncoder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-text-encoder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProjectcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projectc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlangGptCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slang.gpt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EeCodegeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ee.codegenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevicetoolCpupower(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devicetool.cpupower {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Googlr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"googlr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HttpsCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"https-check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Licensecollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"licensecollector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HuishouDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"huishou.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ErrorcodesNetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"errorcodes-net-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PgpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pgp-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command U3dotConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"u3dot.converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Markdowncli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"markdowncli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command V7Filecreater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"v7.filecreater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChvlpfGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chvlpf.gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RednbCodeioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rednb.codeio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsExetomsi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.exetomsi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command X2cs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"x2cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetVsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-vs-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Repoclean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"repoclean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EmpoweredDataverseConvenience(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"empowered.dataverse.convenience {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command J2cs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"j2cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NabsToolsMigrationscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nabs.tools.migrationscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GdrescheckerChecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gdreschecker.checker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HaiCliSugar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hai.cli.sugar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TopswagcodeClizerDev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"topswagcode.clizer.dev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JobbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jobb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MusictopiaWebuploadsharedclientservertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"musictopia.webuploadsharedclientservertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PascallyMilleniumfalconCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pascally.milleniumfalcon.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LildotnetcoreWaffleV01(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lildotnetcore.waffle.v01 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TyConvert64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ty.convert64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNugetize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nugetize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Regitlintfix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"regitlintfix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EcJsonGeneratorToCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ec.json.generator.to.csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DbbrokerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbbroker.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nocker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nocker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McpDbConnect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcp-db-connect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nonogramcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nonogramcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IgeekfanFreekitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"igeekfan.freekit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XamsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xams.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rocketleaguereplayparsercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rocketleaguereplayparsercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlnfgenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slnfgen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JcTomdConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jc.tomd.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SchemathiefCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"schemathief-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DatalustPiggyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datalust.piggy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SgnsharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sgnsharp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EmpoweredDataverseConnection(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"empowered.dataverse.connection {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VsmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vsm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kidde82Dotcovercoveragevalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kidde82.dotcovercoveragevalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DeimdalJsonschemaconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deimdal.jsonschemaconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PlaywrightSharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"playwright-sharp-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UlissesConfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ulisses.config {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WhizbangCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"whizbang.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MbwToolsCsprojformatter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mbw.tools.csprojformatter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetrsa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetrsa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TinyrecoilCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tinyrecoil.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sublimecommit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sublimecommit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GobiInsyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gobi.insync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QiqiQiqiplus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qiqi.qiqiplus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WhipstaffEfdiagram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"whipstaff-efdiagram {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnipharDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uniphar.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ModelingevolutionMjpegCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"modelingevolution.mjpeg.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Query2pocoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"query2poco.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScripsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scrips.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Shu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DigitalrootModuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"digitalroot.moduploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDstrings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dstrings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetJerry(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-jerry {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Simplet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simplet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnipiNancyPlaygroundCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unipi.nancy.playground.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToolClueeTech(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tool.cluee.tech {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Typedocconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typedocconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command HyrmnTrx2csv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hyrmn.trx2csv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SamhowesInsightCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samhowes.insight.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Oaclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oaclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Parsecalc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"parsecalc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PlugfyCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"plugfy.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WsdsoftwareCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wsdsoftware.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlangCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slang.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RumbleCowsayTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rumble.cowsay.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MniCoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mni.core.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MusictopiaCssclassconstdesigner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"musictopia.cssclassconstdesigner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Examplecommandrock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"examplecommandrock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}