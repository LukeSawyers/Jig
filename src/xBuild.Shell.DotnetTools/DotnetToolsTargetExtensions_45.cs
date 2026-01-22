using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T EquadratLicensingCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"equadrat.licensing.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OcelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ocel-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HitrefreshScheduleCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hitrefresh.schedule-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PotToCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pot_to_csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZeroLazCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zero.laz.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ThelairCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thelair.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetCodeSqlconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"net.code.sqlconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JsonpathCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jsonpath-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitcontrolcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitcontrolcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotsefClippy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotsef-clippy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TricepCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tricep.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Modshardchecksum(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"modshardchecksum {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generator_cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MonolithCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"monolith-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HtmlFormsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"html.forms.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GrantthomasCrudCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"grantthomas.crud.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTextEncoder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-text-encoder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProjectcCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projectc.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlangGptCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slang.gpt.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EeCodegeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ee.codegenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevicetoolCpupower(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devicetool.cpupower {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Googlr(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"googlr {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HttpsCheck(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"https-check {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Licensecollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"licensecollector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HuishouDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"huishou.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ErrorcodesNetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"errorcodes-net-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PgpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pgp-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T U3dotConverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"u3dot.converter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Markdowncli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"markdowncli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T V7Filecreater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"v7.filecreater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChvlpfGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chvlpf.gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RednbCodeioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rednb.codeio.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsExetomsi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.exetomsi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T X2cs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"x2cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetVsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-vs-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Repoclean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"repoclean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EmpoweredDataverseConvenience(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"empowered.dataverse.convenience {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T J2cs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"j2cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NabsToolsMigrationscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nabs.tools.migrationscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GdrescheckerChecker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gdreschecker.checker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HaiCliSugar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hai.cli.sugar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TopswagcodeClizerDev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"topswagcode.clizer.dev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JobbCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jobb.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MusictopiaWebuploadsharedclientservertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"musictopia.webuploadsharedclientservertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PascallyMilleniumfalconCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pascally.milleniumfalcon.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LildotnetcoreWaffleV01(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lildotnetcore.waffle.v01 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TyConvert64(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ty.convert64 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNugetize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nugetize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Regitlintfix(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"regitlintfix {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EcJsonGeneratorToCsharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ec.json.generator.to.csharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DbbrokerCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbbroker.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nocker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nocker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McpDbConnect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcp-db-connect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nonogramcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nonogramcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IgeekfanFreekitCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"igeekfan.freekit.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XamsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xams.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rocketleaguereplayparsercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rocketleaguereplayparsercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlnfgenCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slnfgen.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JcTomdConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jc.tomd.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SchemathiefCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"schemathief-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DatalustPiggyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datalust.piggy.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SgnsharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sgnsharp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EmpoweredDataverseConnection(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"empowered.dataverse.connection {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VsmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vsm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kidde82Dotcovercoveragevalidator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kidde82.dotcovercoveragevalidator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DeimdalJsonschemaconvert(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deimdal.jsonschemaconvert {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PlaywrightSharpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"playwright-sharp-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UlissesConfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ulisses.config {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WhizbangCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"whizbang.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MbwToolsCsprojformatter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mbw.tools.csprojformatter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetrsa(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetrsa {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TinyrecoilCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tinyrecoil.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sublimecommit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sublimecommit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GobiInsyncCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gobi.insync.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QiqiQiqiplus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qiqi.qiqiplus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WhipstaffEfdiagram(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"whipstaff-efdiagram {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnipharDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uniphar.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ModelingevolutionMjpegCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"modelingevolution.mjpeg.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Query2pocoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"query2poco.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScripsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scrips.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Shu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DigitalrootModuploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"digitalroot.moduploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDstrings(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dstrings {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetJerry(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-jerry {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Simplet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simplet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnipiNancyPlaygroundCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unipi.nancy.playground.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToolClueeTech(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tool.cluee.tech {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Typedocconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typedocconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T HyrmnTrx2csv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hyrmn.trx2csv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SamhowesInsightCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samhowes.insight.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Oaclientgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oaclientgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Parsecalc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"parsecalc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PlugfyCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"plugfy.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WsdsoftwareCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wsdsoftware.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlangCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slang.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RumbleCowsayTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rumble.cowsay.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MniCoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mni.core.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MusictopiaCssclassconstdesigner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"musictopia.cssclassconstdesigner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Examplecommandrock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"examplecommandrock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}