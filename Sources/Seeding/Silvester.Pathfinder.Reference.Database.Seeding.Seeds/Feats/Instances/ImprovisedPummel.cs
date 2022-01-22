using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovisedPummel : Template
    {
        public static readonly Guid ID = Guid.Parse("ada9e97f-1a4f-4e5c-bed0-7e6ce2335e3c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvised Pummel",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff80b004-e55a-482f-b07b-2b485b947317"), Type = TextBlockType.Text, Text = $"You make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your wielded improvised weapon. You gain a +1 item bonus to the attack roll, and the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals two weapon damage dice if it would have dealt fewer. If the attack is a critical hit, in addition to the effect of the critical hit, the improvised weapon breaks. If the item has a Hardness greater than your level, or if it's an artifact, cursed item, or other item that's difficult to break or destroy, the item doesn't break and the attack is a hit instead of a critical hit." };
            yield return new TextBlock { Id = Guid.Parse("ef76a386-c3f2-4857-8794-670c5b3025e4"), Type = TextBlockType.Text, Text = $"At 12th level, your item bonus to the attack roll increases to +2 instead of +1, and at 16th level, the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals three weapon damage dice if it would have dealt fewer, instead of two." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cf200b24-12d1-4eac-9ad4-4ef4d82e2fa5"), Feats.Instances.WeaponImproviserDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac07daec-f81c-44a3-9c55-f1778b432118"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
