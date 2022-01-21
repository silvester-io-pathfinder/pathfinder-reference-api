using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ContinualFlame : Template
    {
        public static readonly Guid ID = Guid.Parse("d253d16d-cbac-4673-a25f-0a3c33173cd1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Continual Flame",
                Level = 2,
                Range = "Touch.",
                Targets = "1 object.",
                Duration = "Unlimited",
                Requirements = "6 gp of ruby dust.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("105c17e6-07ad-43f7-9868-476bb1f9d1c0"), Type = Utilities.Text.TextBlockType.Text, Text = "A magical flame springs up from the object, as bright as a torch. It doesn't need oxygen, react to water, or generate heat." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("fd04a9d3-8d55-49b6-ab6f-863cfda50de7"), 
                Level = "3rd", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e524c2fd-7a86-4c19-b8ea-3d8b0734620c"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell is more difficult to counteract and resist, but the cost is increased to 16gp." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("c15bae80-bafd-4214-a887-e8dc349d2a51"),
                Level = "4th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e6c9e4fd-5660-4705-b1cb-6e1e7ed93d9b"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell is more difficult to counteract and resist, but the cost is increased to 30gp." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("ecdcd196-a2f7-4eff-a302-36829c060875"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c398bd37-7c19-40ce-a838-a28e73c4e02f"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell is more difficult to counteract and resist, but the cost is increased to 60gp." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("20e9bfe7-6e9d-4e2d-ae10-68455f7a75dc"), 
                Level = "6th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c96b526b-bd6b-4623-b246-d1a0f65f0caa"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell is more difficult to counteract and resist, but the cost is increased to 120gp." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("70f8b982-3a29-4498-89e7-eee2ead46d0f"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("54f377ad-2e27-4f91-bfe8-ea7fded1b56c"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell is more difficult to counteract and resist, but the cost is increased to 270gp." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("26042150-1558-43d2-acd2-8a75c20f513e"), 
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("29355096-23ed-46cf-a99e-f61317b1616f"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell is more difficult to counteract and resist, but the cost is increased to 540gp." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("79854345-f541-48f2-8e04-8401e71c598b"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f0aa21d3-d5ed-4491-af22-e1e7bd3e692c"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell is more difficult to counteract and resist, but the cost is increased to 1350gp." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("fa60eb32-a8f7-4129-ac79-86db2b0c6e85"), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b0047551-8881-4a42-a565-7579beab9b8c"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell is more difficult to counteract and resist, but the cost is increased to 3350gp." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ff642942-d361-4e5d-b741-474600fc66ac"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("1b8ae729-416f-4e7f-84d4-b931cc3e7825"), Traits.Instances.Light.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80ed5697-a67f-42cb-83b1-58b49b6f0fbe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 326
            };
        }
    }
}
