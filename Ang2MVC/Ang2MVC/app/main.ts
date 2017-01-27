import './polyfills.js';

import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { enableProdMode } from '@angular/core';
//import { environment } from '../environments/enviroment.ts';
import { AppModule } from './app.module';

//if (production) {
//	enableProdMode();
//}

platformBrowserDynamic().bootstrapModule(AppModule);