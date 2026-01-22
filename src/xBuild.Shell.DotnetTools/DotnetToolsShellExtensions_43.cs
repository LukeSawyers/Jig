using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command HyperfabricClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hyperfabric.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LuauCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"luau-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KubeclientToolsGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kubeclient.tools.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CowsayCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cowsay.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Solacetestclient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solacetestclient {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Opencrmsvcutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"opencrmsvcutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WeixinCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"weixin.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SkylineDataminerCicdToolsSyncnugets(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"skyline.dataminer.cicd.tools.syncnugets {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitStandupCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-standup-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCertificateToolSm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-certificate-tool-sm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeometrydashConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"geometrydash.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FhiHelseidselvbetjeningCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fhi.helseidselvbetjening.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCsv2dbf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-csv2dbf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RestyardGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"restyard.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CloggerTui(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"clogger.tui {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MctCarecloudCliCc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mct.carecloud.cli.cc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Imagile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"imagile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tinyca(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tinyca {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SigningserverClient(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"signingserver.client {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChocoreCommand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chocore.command {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeziantouToolsPdftocbz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meziantou.tools.pdftocbz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntegrationmocksCleaner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"integrationmocks.cleaner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Consolesharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"consolesharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SwaggerCsv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"swagger-csv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CcTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cc.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FhiSecurityCryptographyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fhi.security.cryptography.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetwhoiscli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetwhoiscli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DemaconsultingDoxygentool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"demaconsulting.doxygentool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StepreportCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stepreport.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ContractopsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"contractops-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LadeakChttpexec(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ladeak.chttpexec {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitcontributors(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitcontributors {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MbutilsCloudformationstackdeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mbutils.cloudformationstackdeployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Tomlconfigtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tomlconfigtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pdftoolcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pdftoolcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mydotnetcoretool1999(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mydotnetcoretool1999 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PasswordsafeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"passwordsafe.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScriptorConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scriptor.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ContoSpacesConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"conto.spaces.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EliassenFileragengineCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"eliassen.fileragengine.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MintplayerCodemigrationsRunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mintplayer.codemigrations.runner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pocotocsla(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pocotocsla {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TypeforgeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"typeforge.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IntrospectorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"introspector.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TaclCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tacl-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rw7DotnetsecuritytoolsClientcredentialsgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rw7.dotnetsecuritytools.clientcredentialsgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Surveying3dCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"surveying3d-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Monarch75ToolsCachewarming(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"monarch75.tools.cachewarming {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TpmCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tpm.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRetest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-retest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MarymoorstudiosCoreCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"marymoorstudios.core.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolhigsonFrameworkEfcoretoolgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solhigson.framework.efcoretoolgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkCmmdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.cmmdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DragonhillDevopsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dragonhill.devops.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGitlabChangelogGen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gitlab-changelog-gen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Minifiercli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minifiercli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotsefChroma(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotsef-chroma {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScaleoutDigitaltwinCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scaleout.digitaltwin.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LucewaveCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lucewave.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MonbsoftUpdateversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"monbsoft.updateversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProjectCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"project-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VerifyTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"verify.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkCircle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.circle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MinesweeperCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minesweeper.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SoftwarefactoryLoreplugin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"softwarefactory.loreplugin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetProj(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-proj {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CalqframeworkDvo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"calqframework.dvo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LindexiToolCopytoclipboard(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lindexi.tool.copytoclipboard {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LoxsmokeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"loxsmoke.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SolrevdevSeedfolder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"solrevdev.seedfolder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gfic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gfic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PlaylistConv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"playlist-conv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotsightsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotsights.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SonaCompilerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sona.compiler.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DependifyCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependify.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Reoconfigurationupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reoconfigurationupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TbcConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tbc.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codegeneratorsigeer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codegeneratorsigeer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SuiClientServiceWatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sui.client.service.watcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WdaCf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wda-cf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Metabasecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metabasecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetschoolCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netschool.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LorecopilotLoreplugin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lorecopilot.loreplugin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LionwebCsharpGeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lionweb-csharp-generator-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTarballCleanup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tarball-cleanup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Json2sharpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"json2sharp-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Chinesestringrefactortool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chinesestringrefactortool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Intervalcrongeneratorcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"intervalcrongeneratorcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Classnugetdemo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"classnugetdemo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Schemazen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"schemazen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusSvg2xamltool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.svg2xamltool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RksoftwareDotnettoolupdatecheckerconsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rksoftware.dotnettoolupdatecheckerconsole {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FlowonXrmToolsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"flowon.xrm.tools.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KangarooCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kangaroo.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SawnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sawnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevnasCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devnas.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CubeengineCore(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cubeengine.core {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetcampusWin32processcommandviewerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetcampus.win32processcommandviewer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCertTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-cert-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xsd2cs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xsd2cs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}