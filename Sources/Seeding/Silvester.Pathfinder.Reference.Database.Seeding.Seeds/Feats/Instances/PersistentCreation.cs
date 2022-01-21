using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PersistentCreation : Template
    {
        public static readonly Guid ID = Guid.Parse("212079c5-98a3-4eb6-9189-94a370f14aa5");

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
            yield return new TextBlock { Id = Guid.Parse("8d04cf62-d888-43fd-9a90-0b3e357dd7f1"), Type = TextBlockType.Text, Text = "You can cast (spell: creation) as an innate spell at will, choosing whether it is arcane or primal each time. The created object lasts until you spend 1 hour not within its immediate vicinity or until it is destroyed. Such objects are called persistent creations. If you cast (spell: creation) again, any persistent creation you previously created with the spell immediately disintegrates." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("df4906ad-d708-423d-94cf-1ee603bb60c7"), Feats.Instances.HalcyonSpeakerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f2516b0-f97b-4e0c-9763-2cde7f426b6d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
