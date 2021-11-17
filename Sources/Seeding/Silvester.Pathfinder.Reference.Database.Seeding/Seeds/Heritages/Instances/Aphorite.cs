using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Aphorite : Template
    {
        public static readonly Guid ID = Guid.Parse("14123045-0255-4785-bc56-e85f9d6ebfde");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                Name = "Aphorite"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1d22c977-ae85-4fae-95eb-9627ba1ec859"), Type = TextBlockType.Text, Text = "You were born with a connection to Axis, the Plane of Law. You gain the aphorite trait, in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from aphorite feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("52acdb4a-bd43-47c8-953f-a6a95accf9a7"), Traits.Instances.Aphorite.ID);
            builder.AddOr(Guid.Parse("2a81c68a-82ee-4d36-a1f8-4f41be7bd5ac"), or =>
            {
                builder.GainSpecificSense(Guid.Parse("24e994b8-e245-4a00-8744-f5e07b5ac1d9"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                builder.GainSpecificSense(Guid.Parse("8d3c995b-3ee0-4862-a095-aaffe6c6d9ab"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse("f385093c-ec26-4f75-a529-f1a3fbf9d952"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse("ab265c61-adb4-4015-8837-4bbe0c32729d"), Senses.Instances.LowLightVision.ID);
                    });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cdcbd81-c937-47d2-b2a0-cfb94b0866fc"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 75
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
            yield return Gnome.ID;
            yield return Goblin.ID;
            yield return Human.ID;
            yield return Tengu.ID;
            yield return Orc.ID;
            yield return Dwarf.ID;
            yield return Kobold.ID;
            yield return Ratfolk.ID;
            yield return Elf.ID;
            yield return Halfling.ID;
        }
    }
}
