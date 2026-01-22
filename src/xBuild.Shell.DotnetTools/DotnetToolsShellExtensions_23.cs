using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command SatorimagingDotnettoolStaticimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"satorimaging.dotnettool.staticimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Midirec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"midirec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSoddi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-soddi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMlb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mlb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RvCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rv-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CodelightlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codelightly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Msgpack2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"msgpack2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gummycat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gummycat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RiversideJsonbinderConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"riverside.jsonbinder.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RedlineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"redline.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Thirdpartynoticesgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thirdpartynoticesgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Topcover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"topcover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpatialfocusFocusinit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spatialfocus.focusinit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fstsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fstsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Harbor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"harbor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JjnguyNuhubConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jjnguy.nuhub.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xcodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xcodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Zipper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zipper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWhatsnew(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-whatsnew {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cloneleeroy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cloneleeroy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Licensecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"licensecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCmdref(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cmdref {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VsrenamerGui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"vsrenamer_gui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DanturcoGooglemapexport2kml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"danturco.googlemapexport2kml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Octoconfigtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octoconfigtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Boxwebhooktool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"boxwebhooktool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Twitterdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"twitterdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Bfcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"bfcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rember(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rember {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dockerwaiter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dockerwaiter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LocaltunnelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"localtunnel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SqlservercoverageCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlservercoverage.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Squaddailyreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"squaddailyreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScaleoutDigitaltwinToolsMessagerecording(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scaleout.digitaltwin.tools.messagerecording {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OocxSemanticreleaseGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oocx.semanticrelease.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ForgedonceLauncherMsbuildDefaultClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"forgedonce.launcher.msbuild.default.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Filemovermcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"filemovermcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Setresolution(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"setresolution {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xopendoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xopendoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LiquidCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"liquid.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nocco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nocco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gensam(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gensam {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ZebusMessagedslTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"zebus.messagedsl.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CarfyOmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"carfy.om.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SlackjawTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slackjaw.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitstats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitstats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Recolor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"recolor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sa1201ier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sa1201ier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetstarterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetstarter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command McqdbNscriptCs2jsc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcqdb.nscript.cs2jsc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PicklesCommandlineWin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pickles.commandline.win {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetProperties(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-properties {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Googlephotos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"googlephotos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MarathonCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"marathon.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dll2mmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dll2mmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Kindversiondata(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kindversiondata {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Onmapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"onmapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PlaylineConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"playline.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CiltoolsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ciltools.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Blazorjsinteropgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"blazorjsinteropgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Licensegatherer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"licensegatherer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NewbeMcrmirror(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"newbe.mcrmirror {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OfcoursedudeDotnetUpdatetools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ofcoursedude.dotnet-updatetools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Openapi2excelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapi2excel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Filehash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"filehash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Myfirsttoolrandomnothing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"myfirsttoolrandomnothing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Multipublish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"multipublish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Idgeneratorsystem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"idgeneratorsystem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LensfunnetUndist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lensfunnet-undist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UsedataJsonGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"usedata.json.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-csproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Goh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"goh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitignoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitignore-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PicklesCommandlineLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pickles.commandline.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SecureconfigEncrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"secureconfig.encrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EmbedioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"embedio-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Optimustool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"optimustool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EsiurCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"esiur.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LabotechLink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"labotech.link {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Efscriptgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"efscriptgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Osdpspy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"osdpspy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Repolauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"repolauncher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCheckUpdates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-check-updates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ClaveSwaggercompare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clave.swaggercompare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCombine(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-combine {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Filebasedconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"filebasedconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OrcoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"orco.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VerifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"verify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MichalbialeckiComMiktrain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"michalbialecki.com.miktrain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetEncrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-encrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsdistancefield(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsdistancefield {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GmanSpecflowtomarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gman.specflowtomarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OptimizeImage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"optimize-image {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NovadropScan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"novadrop-scan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ConsoleWeather(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"console-weather {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SvrooijTeamsmonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"svrooij.teamsmonitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sharppythoncompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sharppythoncompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NovadropRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"novadrop-run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demo-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}