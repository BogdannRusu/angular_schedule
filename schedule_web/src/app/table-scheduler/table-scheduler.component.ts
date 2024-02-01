import {
  NgModule, Component, Pipe, PipeTransform, enableProdMode,
} from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import {
  DxDataGridModule,
  DxBulletModule,
  DxTemplateModule,
} from 'devextreme-angular';
import DataSource from 'devextreme/data/data_source';
import { TableSchedulerService } from './table-scheduler.service';

if (!/localhost/.test(document.location.host)) {
  enableProdMode();
}

@Component({
  selector: 'app-table-scheduler',
  templateUrl: './table-scheduler.component.html',
  styleUrls: ['./table-scheduler.component.css'],
  providers: [TableSchedulerService],
})
export class TableSchedulerComponent {
  dataSource: DataSource;

  collapsed = false;

  contentReady = (e) => {
    if (!this.collapsed) {
      this.collapsed = true;
      e.component.expandRow(['EnviroCare']);
    }
  };

  customizeTooltip = (pointsInfo) => ({ text: `${parseInt(pointsInfo.originalValue)}%` });

  constructor(service: TableSchedulerService) {
    this.dataSource = service.getDataSource();
  }
}

@NgModule({
  imports: [
    DxDataGridModule,
    DxBulletModule,
    DxTemplateModule,
  ],
  declarations: [],
  bootstrap: [TableSchedulerComponent],
})
export class TableScheduleComponent { }

platformBrowserDynamic().bootstrapModule(TableScheduleComponent);