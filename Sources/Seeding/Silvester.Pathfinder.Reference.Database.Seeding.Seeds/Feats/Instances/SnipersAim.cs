using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnipersAim : Template
    {
        public static readonly Guid ID = Guid.Parse("13f3cda5-bf61-4b6b-a07a-80df68a1c8b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sniper's Aim",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("62064ad5-c5c7-4090-9092-1fb58274630c"), Type = TextBlockType.Text, Text = $"You take an extra moment to carefully sync your aim and breathing, then fire a shot with great accuracy. Make a ranged weapon {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. You gain a +2 circumstance bonus to this {ToMarkdownLink<Models.Entities.Action>("Strike's", Actions.Instances.Strike.ID)} attack roll and ignore the target's concealment. If you're using a {ToMarkdownLink<Models.Entities.Trait>("kickback", Traits.Instances.Kickback.ID)} firearm, you don't take the normal circumstance penalty on this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} for not having the required Strength score or firing without using a stabilizer." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("0fc7d580-adf5-4e48-a475-2280078261b9"), GunslingersWays.Instances.WayOfTheSniper.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04e76ce4-13e5-472a-9e8f-5a4fb46e5554"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
