using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UrgentUpwelling : Template
    {
        public static readonly Guid ID = Guid.Parse("c99ae53d-3633-4055-b3e1-829de96b6c77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Urgent Upwelling",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy reduces you to 0 HP, an enemy critically hits you, or you critically fail a saving throw against an enemy's effect.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd22f1f9-2790-429b-999f-31ad49230e2b"), Type = TextBlockType.Text, Text = $"Defeat lets you to tap into your wellspring. Attempt the flat check for wellspring magic. If you critically succeed, you can choose to forgo gaining a temporary spell slot to instead have the triggering enemy undergo a wellspring surge. This surge functions just as it would for you, the only difference being that it emits from the enemy." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d434b41d-82b8-48b8-aee5-18c77e5009fc"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d2807be-dbf4-4c3b-a137-c4c9ea2eed7e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
