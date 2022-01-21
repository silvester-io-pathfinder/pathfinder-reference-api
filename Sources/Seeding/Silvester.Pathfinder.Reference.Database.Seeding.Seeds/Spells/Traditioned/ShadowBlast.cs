using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("6ef98fbc-537b-47fb-876a-6c9bec29fe98");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow Blast",
                Level = 5,
                Range = "Varies.",
                Area = "Varies.",
                Addendum = "The target can choose instead to perform a basic Will save, instead of a basic Reflex save.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4776335-839d-4ca9-b082-0362ec6ea3ef"), Type = TextBlockType.Text, Text = "You shape the quasi-real substance of the Shadow Plane into a blast. Choose acid, bludgeoning, cold, electricity, fire, force, piercing, slashing, or sonic damage, and choose a 30-foot cone, a 15-foot burst within 120 feet, or a 50-foot line. The blast deals 5d8 damage of the type you chose to each creature in the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("549e6cd2-fb09-48f1-8afd-591c1a90bc67"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6ab3dc0a-b9c9-427b-a783-c77a549fa3cb"), Type = TextBlockType.Text, Text = "The damage increases by 1d8." }
                }
            };
        }
        
        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0868524e-34dc-4a9c-b1eb-465c44b8be08"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("af48b2fc-3f85-4f71-aef1-b84b4b7efb0f"), Traits.Instances.Shadow.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a795963b-f960-4144-942f-327ca278198b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 367
            };
        }
    }
}
