using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T SatorimagingDotnettoolStaticimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"satorimaging.dotnettool.staticimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Midirec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"midirec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSoddi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-soddi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMlb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mlb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RvCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rv-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CodelightlyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codelightly.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Msgpack2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"msgpack2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gummycat(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gummycat {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RiversideJsonbinderConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"riverside.jsonbinder.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RedlineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"redline.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Thirdpartynoticesgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thirdpartynoticesgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Topcover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"topcover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpatialfocusFocusinit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spatialfocus.focusinit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fstsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fstsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Harbor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"harbor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JjnguyNuhubConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jjnguy.nuhub.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xcodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xcodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Zipper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zipper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWhatsnew(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-whatsnew {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cloneleeroy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cloneleeroy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Licensecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"licensecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCmdref(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cmdref {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VsrenamerGui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"vsrenamer_gui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DanturcoGooglemapexport2kml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"danturco.googlemapexport2kml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Octoconfigtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octoconfigtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Boxwebhooktool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"boxwebhooktool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Twitterdump(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"twitterdump {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Bfcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"bfcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rember(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rember {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dockerwaiter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dockerwaiter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LocaltunnelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"localtunnel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SqlservercoverageCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlservercoverage.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Squaddailyreport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"squaddailyreport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScaleoutDigitaltwinToolsMessagerecording(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scaleout.digitaltwin.tools.messagerecording {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OocxSemanticreleaseGlobaltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oocx.semanticrelease.globaltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ForgedonceLauncherMsbuildDefaultClitool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"forgedonce.launcher.msbuild.default.clitool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Filemovermcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"filemovermcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Setresolution(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"setresolution {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xopendoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xopendoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LiquidCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"liquid.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nocco(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nocco {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gensam(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gensam {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ZebusMessagedslTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"zebus.messagedsl.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CarfyOmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"carfy.om.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SlackjawTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slackjaw.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitstats(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitstats {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Recolor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"recolor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sa1201ier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sa1201ier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetstarterCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetstarter.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T McqdbNscriptCs2jsc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcqdb.nscript.cs2jsc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PicklesCommandlineWin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pickles.commandline.win {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetProperties(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-properties {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Googlephotos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"googlephotos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MarathonCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"marathon.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dll2mmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dll2mmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Kindversiondata(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kindversiondata {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Onmapper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"onmapper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PlaylineConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"playline.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CiltoolsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ciltools.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Blazorjsinteropgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"blazorjsinteropgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Licensegatherer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"licensegatherer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NewbeMcrmirror(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"newbe.mcrmirror {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OfcoursedudeDotnetUpdatetools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ofcoursedude.dotnet-updatetools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Openapi2excelCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapi2excel.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Filehash(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"filehash {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Myfirsttoolrandomnothing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"myfirsttoolrandomnothing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Multipublish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"multipublish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Idgeneratorsystem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"idgeneratorsystem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LensfunnetUndist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lensfunnet-undist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UsedataJsonGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"usedata.json.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCsproj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-csproj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Goh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"goh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitignoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitignore-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PicklesCommandlineLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pickles.commandline.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SecureconfigEncrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"secureconfig.encrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EmbedioCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"embedio-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Optimustool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"optimustool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EsiurCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"esiur.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LabotechLink(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"labotech.link {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Efscriptgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"efscriptgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Osdpspy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"osdpspy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Repolauncher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"repolauncher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCheckUpdates(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-check-updates {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ClaveSwaggercompare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clave.swaggercompare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCombine(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-combine {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Filebasedconverter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"filebasedconverter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OrcoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"orco.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VerifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"verify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MichalbialeckiComMiktrain(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"michalbialecki.com.miktrain {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetEncrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-encrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsdistancefield(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsdistancefield {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GmanSpecflowtomarkdown(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gman.specflowtomarkdown {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OptimizeImage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"optimize-image {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NovadropScan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"novadrop-scan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ConsoleWeather(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"console-weather {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SvrooijTeamsmonitor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"svrooij.teamsmonitor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sharppythoncompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sharppythoncompiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NovadropRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"novadrop-run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demo-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}