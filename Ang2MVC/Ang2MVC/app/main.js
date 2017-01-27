"use strict";
require('./polyfills.js');
const platform_browser_dynamic_1 = require('@angular/platform-browser-dynamic');
//import { environment } from '../environments/enviroment.ts';
const app_module_1 = require('./app.module');
//if (production) {
//	enableProdMode();
//}
platform_browser_dynamic_1.platformBrowserDynamic().bootstrapModule(app_module_1.AppModule);
//# sourceMappingURL=main.js.map