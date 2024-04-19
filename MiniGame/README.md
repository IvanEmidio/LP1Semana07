``` mermaid

      classDiagram
      class Character {
            # weapons: Weapon
            + Name: string
            + Fight() void

            
      }

      class Player {
            
      }

      class Enemy {

      }

      class Weapon {
            # power: float
      }

      class Sword {
            + BladeLength: float 
            + AttackWithSword() void
      }

      class Gun {
            + Ammo: int
            + FireGun() void
      }

      Character "1" *--> "*" Weapon
      Character <|-- Player
      Character <|-- Enemy
      Weapon <|-- Sword
      Weapon <|-- Gun
```