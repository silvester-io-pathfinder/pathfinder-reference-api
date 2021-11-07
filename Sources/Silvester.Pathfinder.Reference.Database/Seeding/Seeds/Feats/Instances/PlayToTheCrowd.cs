using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlayToTheCrowd : Template
    {
        public static readonly Guid ID = Guid.Parse("e9677284-3d0f-40ee-aef3-b6dbcee2d904");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Play to the Crowd",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You reduce an enemy to 0 Hit Points during a non-trivial combat encounter with spectators.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6983d82f-5365-47e4-94da-6245d8e3af9a"), Type = TextBlockType.Text, Text = "You show off for the crowd. Attempt a Performance check; the DC is determined by the GM but is typically the standard DC for your level or the DC to (action: Make an Impression) on the spectators, whichever is higher. On a success, choose one of the following benefits; on a critical success, choose two benefits:" };
            yield return new TextBlock { Id = Guid.Parse("0622b4a3-723b-4db7-9981-c1c6bfe2bba1"), Type = TextBlockType.Enumeration, Text = " : A number of temporary Hit Points equal to your character level; these last for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("b16f7d2f-8db9-43a3-9a47-3d64d8dca5df"), Type = TextBlockType.Enumeration, Text = " : A +1 circumstance bonus to AC until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("6bf3c18d-d253-4ef6-aa59-eda75caae8f4"), Type = TextBlockType.Enumeration, Text = " : A +1 circumstance bonus to your next attack roll before the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8afb44a6-e5c2-416a-95a0-2265f941726a"), Feats.Instances.GladiatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b54d7f24-98f5-4ecd-b4e3-10f23427bbd5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
