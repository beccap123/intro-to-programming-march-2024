import { Component } from '@angular/core';
import { PageHeaderComponent } from "./components/page-header/page-header.component";

@Component({
  selector: 'app-root',
  standalone: true,
  template: `
    <app-page-header />
    <main>
      <p>Our Stuff Goes Here</p>
</main>

  `,
  styles: [],
  imports: [PageHeaderComponent]
})
export class AppComponent {
}
