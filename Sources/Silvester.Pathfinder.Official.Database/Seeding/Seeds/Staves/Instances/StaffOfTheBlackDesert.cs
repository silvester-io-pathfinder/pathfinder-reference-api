using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfTheBlackDesert : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of the Black Desert",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "his rough metal staff is pitted and sandblasted, with thousands of nigh-imperceptible sand crystals embedded in its surface. While carrying the staff, you gain a +2 circumstance bonus to Occultism checks to identify aberrations and oozes native to the Darklands." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 185000,
                ItemLevel = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), SpellId = Spells.Instances.KnowDirection.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.CreateWater.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.PurifyFoodAndDrink.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.UnseenServant.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.Darkvision.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.EndureElements.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.Earthbind.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.NeutralizePoison.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.WanderersGuide.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.AirWalk.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.HallucinatoryTerrain.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.RopeTrick.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.PillarsOfSand.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.Veil.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 950000,
                ItemLevel = 16,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.PurpleWormSting.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.SummonEntity.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 7, SpellId = Spells.Instances.BlightburnBlast.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 7, SpellId = Spells.Instances.ControlSand.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 7, SpellId = Spells.Instances.UnfetteredPack.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.Pathfinder155.ID,
                Page = 76
            };
        }
    }
}
