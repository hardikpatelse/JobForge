import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  template: `
    <div class="app-container">
      <header>
        <h1>JobForge</h1>
        <p>Job Aggregation Platform - Coming Soon</p>
      </header>
      <main>
        <router-outlet />
      </main>
    </div>
  `,
  styles: [`
    .app-container {
      padding: 2rem;
      max-width: 1200px;
      margin: 0 auto;
    }
    
    header {
      text-align: center;
      margin-bottom: 2rem;
    }
    
    h1 {
      font-size: 2.5rem;
      color: #1a73e8;
      margin-bottom: 0.5rem;
    }
    
    p {
      font-size: 1.2rem;
      color: #666;
    }
  `]
})
export class AppComponent {
  title = 'JobForge';
}
