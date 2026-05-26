# SmartFoods UI Design System

Version: 1.0
UI Strategy: Mobile-First
Design Style: Modern Food-Tech SaaS
Visual Complexity: Level 2
Theme Direction: Fresh Minimal Wellness
Animation Style: Subtle Premium Motion

---

# 1. UI Vision

SmartFoods should feel like:

```text
A modern wellness + productivity application
focused on simplicity, freshness, and calm efficiency.
```

The user experience must feel:

* Friendly
* Modern
* Soft
* Organized
* Professional
* Fast
* Visually satisfying
* Calm and uncluttered

The application should NOT feel:

* Overly corporate
* Cartoonish
* Heavy
* Dense
* Technically intimidating
* Over-animated

---

# 2. Design Philosophy

## Core UX Principles

### 1. Reduce Mental Friction

Users should instantly understand:

* What is expiring
* What action to take
* What recipes they can make

The UI should minimize decision fatigue.

---

### 2. Prioritize Urgency

The dashboard must clearly emphasize:

* Expiring food
* Quick actions
* Suggested solutions

Urgent information must visually dominate.

---

### 3. Mobile-First Experience

The primary UX target is:

```text
Mobile phones first
Desktop second
```

All layouts should:

* Stack naturally on mobile
* Avoid clutter
* Maintain thumb-friendly spacing
* Keep navigation reachable

Desktop layouts should expand naturally without redesigning the interface.

---

### 4. Calm Visual Hierarchy

The UI should rely on:

* White space
* Soft shadows
* Rounded corners
* Gentle gradients
* Soft elevation
* Minimal borders

Instead of:

* Hard outlines
* Heavy contrast
* Excessive colors
* Aggressive animations

---

# 3. Brand Personality

## Brand Keywords

```text
Fresh
Calm
Clean
Helpful
Eco-conscious
Modern
Smart
Friendly
Premium
```

---

# 4. Visual Style Direction

## Inspiration Style

The design language should feel inspired by:

* Notion
* Linear
* Apple Health
* Headspace
* Modern wellness startups

---

# 5. Color System

## Primary Palette

### Primary Green

Use:

```text
Mint / Sage Green
```

Purpose:

* Freshness
* Health
* Sustainability
* Calmness

---

## Core Color Roles

| Purpose               | Color Direction   |
| --------------------- | ----------------- |
| Primary Actions       | Mint Green        |
| Backgrounds           | White / Off-white |
| Cards                 | Soft White        |
| Secondary Backgrounds | Very Light Green  |
| Text Primary          | Deep Neutral Gray |
| Text Secondary        | Soft Gray         |
| Success               | Soft Green        |
| Warning               | Warm Amber        |
| Error                 | Soft Red          |

---

## Gradient Strategy

The application should use:

```text
Very soft gradients only.
```

Examples:

* White → soft mint
* Mint → light sage
* Off-white → pale green

Gradients should feel subtle and premium.

Never use:

* Neon gradients
* Harsh color transitions
* Over-saturated colors

---

# 6. Typography System

## Primary Font

Recommended:

```text
Inter
```

Alternative:

```text
Plus Jakarta Sans
```

---

## Typography Personality

Typography should feel:

* Modern
* Clean
* Highly readable
* Soft but professional

---

## Font Weight Usage

| Usage          | Weight   |
| -------------- | -------- |
| Hero Titles    | Bold     |
| Section Titles | SemiBold |
| Body Text      | Regular  |
| Labels         | Medium   |
| Helper Text    | Regular  |

---

# 7. Spacing System

## UI Density

The application should feel:

```text
Airy and breathable.
```

Use:

* Generous padding
* Clear card separation
* Comfortable touch spacing
* Consistent margins

Avoid:

* Crowded dashboards
* Tight spacing
* Dense information walls

---

# 8. Border Radius System

## Corner Style

Use:

```text
Large soft rounded corners.
```

Recommended:

* Cards: xl/2xl
* Buttons: lg/xl
* Inputs: lg
* Modals: 2xl

The app should feel soft and modern.

---

# 9. Shadow System

## Elevation Strategy

Use:

* Soft layered shadows
* Low opacity shadows
* Hover elevation transitions

Avoid:

* Heavy black shadows
* Aggressive floating effects

---

# 10. Animation System

## Animation Philosophy

Animations should:

* Improve perceived quality
* Guide attention
* Feel smooth and subtle
* Never slow down the app

---

## Approved Motion Types

### Micro Interactions

Examples:

* Button hover scaling
* Card hover elevation
* Soft fade-ins
* Smooth transitions
* Gentle loading animations

---

## Navigation Motion

Examples:

* Smooth route transitions
* Slide/fade mobile menus
* Soft modal animations

---

## Loading Experience

Use:

* Skeleton loaders
* Pulse loading placeholders
* Smooth shimmer effects

Avoid:

* Spinners everywhere
* Flashing loaders

---

# 11. Layout Architecture

## Mobile-First Layout Strategy

### Mobile

Use:

* Bottom navigation
* Stacked cards
* Full-width content
* Floating quick actions

---

### Desktop

Use:

* Left sidebar navigation
* Wider content grid
* Multi-column layouts
* Expanded dashboard sections

The desktop version should feel like:

```text
An expanded version of mobile
NOT a completely different UI.
```

---

# 12. Navigation Design

## Mobile Navigation

Bottom Navigation Tabs:

| Tab       | Purpose           |
| --------- | ----------------- |
| Dashboard | Home overview     |
| Pantry    | Pantry management |
| Recipes   | Recipe discovery  |
| Profile   | User settings     |

---

## Desktop Navigation

Use:

* Persistent left sidebar
* Logo area
* Navigation items
* User section at bottom

---

# 13. Dashboard UX Architecture

## Dashboard Priority Structure

---

## Tier 1 — Urgent Actions

### Highest Priority Components

#### 1. Expiring Soon Section

Purpose:

Immediately alert users to urgent food expiration.

Visual Direction:

* Bold alert cards
* Warm warning colors
* Strong visual emphasis
* Highly visible at top of screen

Suggested Components:

* MudAlert
* Priority cards
* Countdown badges

---

#### 2. Quick Add Item

Purpose:

Reduce friction for pantry logging.

Visual Direction:

* Floating action button
* Sticky add button
* Prominent mobile CTA

UX Goal:

Adding pantry items should take seconds.

---

## Tier 2 — Core Workspace

### 3. Recipe Recommendations

Purpose:

Convert expiring ingredients into meal ideas.

Visual Direction:

* Image-first recipe cards
* Ingredient match indicators
* Smooth horizontal scrolling sections on mobile

Recipe cards should feel:

* Delicious
* Clean
* Easy to browse

---

### 4. Pantry Summary

Purpose:

Quick inventory overview.

Examples:

```text
24 Items in Pantry
6 Fresh Vegetables
3 Expiring Soon
```

Visual Direction:

* Minimal stat cards
* Clean typography
* Soft icons

---

## Tier 3 — Secondary Context

### 5. Saved Recipes

Purpose:

Meal planning and convenience.

Placement:

Lower dashboard section or dedicated page.

---

### 6. Weekly Waste Insights

Purpose:

Future lightweight analytics.

For MVP:

Minimal placeholder visualization only.

---

# 14. Personalized UX

## Greeting System

Dashboard should feel personal.

Examples:

```text
Good evening, Jay 👋

You have 3 ingredients expiring soon.
```

This helps the application feel:

* Human
* Helpful
* Friendly

---

# 15. Pantry Item Design

## Pantry Card Layout

Each pantry item card should display:

* Ingredient name
* Quantity
* Expiration date
* Status color
* Optional ingredient icon/image

---

## Pantry Status Colors

| Status        | Color Direction |
| ------------- | --------------- |
| Fresh         | Soft Green      |
| Expiring Soon | Warm Amber      |
| Expired       | Soft Red        |

---

## Pantry Layout

Use:

* Card-based design
* Responsive wrapping grid
* Same visual system on desktop and mobile

Desktop should:

* Expand card grid naturally
* Preserve mobile visual identity

---

# 16. Recipe Card Design

## Recipe Card Priorities

Recipe cards should emphasize:

1. Food image
2. Ingredient match percentage
3. Recipe title
4. Quick metadata

---

## Recipe Card Feel

Cards should feel:

* Modern
* Premium
* Appetizing
* Browseable

---

# 17. Empty State Design

## Empty State Philosophy

Empty states should:

* Feel encouraging
* Reduce awkwardness
* Teach users what to do next

Use:

* Soft illustrations/icons
* Friendly messaging
* Clear CTA buttons

---

## Example Empty States

### Pantry Empty

```text
Your pantry is looking empty.
Add your first ingredient to get started.
```

---

### Saved Recipes Empty

```text
No saved recipes yet.
Start exploring delicious meals.
```

---

# 18. Modal & Form UX

## Add Pantry Item Experience

Use:

* Modal or bottom drawer
* Minimal required inputs
* Fast completion flow

Fields:

* Ingredient name
* Quantity
* Unit
* Expiration date

---

## Form Design Principles

Forms should:

* Feel lightweight
* Avoid visual overload
* Use large touch targets
* Use inline validation

---

# 19. Responsive Design Rules

## Mobile Rules

Prioritize:

* Thumb reachability
* Large tap targets
* Single-column layouts
* Scroll-friendly design

---

## Tablet Rules

Use:

* Two-column content where appropriate
* Expanded cards
* Wider grids

---

## Desktop Rules

Use:

* Sidebar navigation
* Expanded dashboard layout
* Larger content containers
* Better information spacing

---

# 20. Accessibility Rules

The UI must:

* Maintain readable contrast
* Support keyboard navigation
* Use semantic headings
* Avoid tiny tap targets
* Use readable font sizes

---

# 21. MVP Screen Inventory

## Public Pages

| Page          | Purpose             |
| ------------- | ------------------- |
| Landing Page  | Product marketing   |
| Login Page    | User authentication |
| Register Page | User signup         |

---

## Authenticated Pages

| Page             | Purpose           |
| ---------------- | ----------------- |
| Dashboard        | Main overview     |
| Pantry Page      | Pantry management |
| Recipe Discovery | Recipe browsing   |
| Saved Recipes    | Favorites         |
| Profile/Settings | User settings     |

---

# 22. Shared Components

## Planned Reusable Components

| Component              | Purpose            |
| ---------------------- | ------------------ |
| Navbar                 | Navigation         |
| Mobile Bottom Nav      | Mobile navigation  |
| Sidebar                | Desktop navigation |
| Pantry Card            | Pantry display     |
| Recipe Card            | Recipe display     |
| Stat Card              | Dashboard metrics  |
| Status Badge           | Expiration state   |
| Skeleton Loader        | Loading state      |
| Empty State            | No-content UX      |
| Floating Action Button | Quick add          |
| Toast Notifications    | Feedback           |

---

# 23. Visual Quality Target

The target quality level is:

```text
Modern startup-quality MVP.
```

NOT:

* Basic student CRUD UI
* Enterprise corporate dashboard
* Over-designed award website

The balance should be:

```text
Clean + modern + friendly + practical.
```

---

# 24. Future UI Expansion Readiness

The design system should support future:

* Dark mode
* Mobile app
* Shared family pantry
* AI features
* Analytics dashboard
* Push notifications

WITHOUT redesigning the visual foundation.

---

# 25. Final UI Direction Summary

SmartFoods should feel like:

```text
A premium modern food-management app
that helps users reduce waste
through a calm, clean, and intelligent interface.
```

The experience should combine:

* Minimalism
* Freshness
* Professionalism
* Soft animations
* Mobile-first usability
* Friendly guidance
