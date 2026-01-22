using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T HyperfabricClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hyperfabric.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LuauCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"luau-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KubeclientToolsGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kubeclient.tools.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CowsayCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cowsay.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Solacetestclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solacetestclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Opencrmsvcutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"opencrmsvcutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WeixinCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"weixin.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SkylineDataminerCicdToolsSyncnugets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.syncnugets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitStandupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-standup-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCertificateToolSm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-certificate-tool-sm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeometrydashConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"geometrydash.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FhiHelseidselvbetjeningCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fhi.helseidselvbetjening.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCsv2dbf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-csv2dbf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RestyardGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"restyard.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CloggerTui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"clogger.tui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MctCarecloudCliCc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mct.carecloud.cli.cc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Imagile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"imagile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tinyca(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tinyca {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SigningserverClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"signingserver.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChocoreCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chocore.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeziantouToolsPdftocbz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meziantou.tools.pdftocbz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntegrationmocksCleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"integrationmocks.cleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Consolesharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"consolesharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SwaggerCsv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"swagger-csv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CcTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cc.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FhiSecurityCryptographyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fhi.security.cryptography.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetwhoiscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetwhoiscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DemaconsultingDoxygentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"demaconsulting.doxygentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StepreportCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stepreport.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ContractopsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"contractops-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LadeakChttpexec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ladeak.chttpexec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitcontributors(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitcontributors {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MbutilsCloudformationstackdeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mbutils.cloudformationstackdeployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Tomlconfigtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tomlconfigtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pdftoolcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pdftoolcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mydotnetcoretool1999(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mydotnetcoretool1999 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PasswordsafeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"passwordsafe.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScriptorConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scriptor.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ContoSpacesConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"conto.spaces.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EliassenFileragengineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"eliassen.fileragengine.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MintplayerCodemigrationsRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mintplayer.codemigrations.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pocotocsla(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pocotocsla {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TypeforgeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"typeforge.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IntrospectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"introspector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TaclCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tacl-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rw7DotnetsecuritytoolsClientcredentialsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rw7.dotnetsecuritytools.clientcredentialsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Surveying3dCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"surveying3d-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Monarch75ToolsCachewarming(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"monarch75.tools.cachewarming {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TpmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tpm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRetest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-retest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MarymoorstudiosCoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"marymoorstudios.core.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolhigsonFrameworkEfcoretoolgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solhigson.framework.efcoretoolgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkCmmdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.cmmdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DragonhillDevopsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dragonhill.devops.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGitlabChangelogGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gitlab-changelog-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Minifiercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minifiercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotsefChroma(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotsef-chroma {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScaleoutDigitaltwinCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scaleout.digitaltwin.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LucewaveCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lucewave.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MonbsoftUpdateversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"monbsoft.updateversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProjectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"project-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VerifyTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"verify.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkCircle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.circle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MinesweeperCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minesweeper.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SoftwarefactoryLoreplugin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"softwarefactory.loreplugin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetProj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-proj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CalqframeworkDvo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"calqframework.dvo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LindexiToolCopytoclipboard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lindexi.tool.copytoclipboard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LoxsmokeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"loxsmoke.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SolrevdevSeedfolder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"solrevdev.seedfolder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gfic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gfic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PlaylistConv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"playlist-conv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotsightsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotsights.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SonaCompilerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sona.compiler.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DependifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Reoconfigurationupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reoconfigurationupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TbcConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tbc.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codegeneratorsigeer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codegeneratorsigeer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SuiClientServiceWatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sui.client.service.watcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WdaCf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wda-cf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Metabasecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metabasecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetschoolCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netschool.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LorecopilotLoreplugin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lorecopilot.loreplugin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LionwebCsharpGeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lionweb-csharp-generator-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTarballCleanup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tarball-cleanup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Json2sharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"json2sharp-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Chinesestringrefactortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chinesestringrefactortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Intervalcrongeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"intervalcrongeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Classnugetdemo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"classnugetdemo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Schemazen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"schemazen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusSvg2xamltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.svg2xamltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RksoftwareDotnettoolupdatecheckerconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rksoftware.dotnettoolupdatecheckerconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FlowonXrmToolsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"flowon.xrm.tools.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KangarooCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kangaroo.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SawnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sawnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevnasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devnas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CubeengineCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cubeengine.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetcampusWin32processcommandviewerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetcampus.win32processcommandviewer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCertTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-cert-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xsd2cs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xsd2cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}