using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrimInsight : Template
    {
        public static readonly Guid ID = Guid.Parse("19fa766b-72cb-4b08-8722-e24a2440cf6b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grim Insight",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f563b7c-17d3-4e82-9461-ccf1b243865c"), Type = TextBlockType.Text, Text = "Others’ attempts to scare you often grant you insights about your would-be bullies that you can then exploit. If you roll a success on a saving throw against a (trait: fear) effect, you get a critical success instead, and the source of the (trait: fear) effect is flat-footed to you until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("e1f7ce25-6322-4960-bcd4-eac8dd52bcc4"), Heritages.Instances.UmbralGnome.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ae4115d-2769-4432-8866-bd3dc3ecf524"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
