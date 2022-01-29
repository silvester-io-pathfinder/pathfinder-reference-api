using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RakshasaMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("77246404-130d-4578-b7cb-e1f3f1bd68ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rakshasa Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("596ffa7d-a786-494e-a32f-55c684ba4477"), Type = TextBlockType.Text, Text = $"You remember the secrets of your rakshasa forebears and know how to apply those memories to get results. You can cast {ToMarkdownLink<Models.Entities.Spell>("humanoid form", Spells.Instances.HumanoidForm.ID)} and {ToMarkdownLink<Models.Entities.Spell>("illusory creature", Spells.Instances.IllusoryCreature.ID)} once per day each as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("953bf949-c071-4089-a9d6-3e4eba1043d5"), Feats.Instances.Beastbrood.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("344e6a67-88c8-412a-8742-be21da294a2e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
