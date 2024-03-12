import { Component } from '@angular/core';

@Component({
  selector: 'app-page-header',
  standalone: true,
  imports: [],
  template: `
    <header>
      <h1 class="font-black text-3xl">Our Angular Application</h1>
      <p>Just Learning Here</p>
    </header>
  `,
  styles: ``,
})
export class PageHeaderComponent {
  someThing = 'Tacos';

  anotherThing = 'cheese';
}
