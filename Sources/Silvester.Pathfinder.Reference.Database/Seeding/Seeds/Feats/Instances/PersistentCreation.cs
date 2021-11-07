using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PersistentCreation : Template
    {
        public static readonly Guid ID = Guid.Parse("3274c04d-6afe-44ad-9f23-f1de2aae79f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Persistent Creation",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd052d4b-4b4e-4b37-9e58-0e378489313d"), Type = TextBlockType.Text, Text = "You can cast (spell: creation) as an innate spell at will, choosing whether it is arcane or primal each time. The created object lasts until you spend 1 hour not within its immediate vicinity or until it is destroyed. Such objects are called persistent creations. If you cast (spell: creation) again, any persistent creation you previously created with the spell immediately disintegrates." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f4828e76-d703-4390-b077-60854704bf58"), Feats.Instances.HalcyonSpeakerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f281723c-5ddd-43a1-8dc1-6f3db3946877"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
