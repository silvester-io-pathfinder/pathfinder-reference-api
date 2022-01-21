using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertBackstabber : Template
    {
        public static readonly Guid ID = Guid.Parse("e67a08d7-77f9-4ab6-bebc-0e17885610d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Backstabber",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51617d35-a9fe-4ec6-b6b7-9472bf2fac00"), Type = TextBlockType.Text, Text = "When you (action: Strike) a flat-footed foe with a weapon that has the (trait: backstabber) weapon trait, you deal 2 extra precision damage instead of 1. If the weapon is a (item: +3 | +3 Weapon Potency Runestone) weapon, you deal 4 extra precision damage instead of 2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("80d086bf-6cf2-4ec0-9a65-306c5c83ecb7"), Feats.Instances.AssassinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b45d86cb-70eb-42ce-9d6f-cf4edd8f5bf7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}