import { app, BrowserWindow } from "electron";
import * as path from "path";
import * as url from "url";
let win;
function createWindow() {
    win = new BrowserWindow({ width: 800, height: 600 });
    win.loadURL(url.format({
        pathname: path.join(__dirname, `/../../dist/ImageBrowser/index.html`),
        protocol: "file:",
        slashes: true
    }));
    win.webContents.openDevTools();
    win.on("closed", () => {
        win = null;
    });
}
app.on("ready", createWindow);
app.on("activate", () => {
    if (win === null) {
        createWindow();
    }
});
// Quit when all windows are closed.
app.on('window-all-closed', () => {
    // On macOS it is common for applications and their menu bar
    // to stay active until the user quits explicitly with Cmd + Q
    if (process.platform !== 'darwin') {
        app.quit();
    }
});
function isRoot() {
    return path.parse(process.cwd()).root == process.cwd();
}
//# sourceMappingURL=main.js.map