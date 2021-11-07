using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickFix : Template
    {
        public static readonly Guid ID = Guid.Parse("67e0f2ce-6178-4c0e-9a5b-cb3b9663ef4c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Fix",
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
            yield return new TextBlock { Id = Guid.Parse("4e54b162-f40c-4149-a3e2-6fc03a185cfb"), Type = TextBlockType.Text, Text = "You can attach a talisman using only a bit of glue and some string. You gain the (feat: Rapid Affixture) skill feat, even if you don’t meet the prerequisites. When you use it, you can affix or remove up to four talismans in 1 minute instead of just one." };
            yield return new TextBlock { Id = Guid.Parse("3039b820-bfbd-432e-bb31-acf866b42067"), Type = TextBlockType.Text, Text = "You gain the ability to (action: Affix a Talisman) as a 3-action activity from that feat at 12th level, regardless of your Crafting proficiency." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("beb4af15-f3e7-40a0-bc27-8814dc601beb"), Feats.Instances.TalismanDabblerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bd14185-220c-4515-a15b-886a6a244460"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
