using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KneelForNoGod : Template
    {
        public static readonly Guid ID = Guid.Parse("5e6886d2-7417-4b74-80dc-07fd59c9426b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kneel For No God",
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
            yield return new TextBlock { Id = Guid.Parse("53c03fa2-32d1-4161-92a9-83e66f13c04f"), Type = TextBlockType.Text, Text = "~ Access: Vahird ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("a2d28bf4-a259-439f-bbab-fd4fc838be87"), Type = TextBlockType.Text, Text = "Your ancestors’ defiance of magic and your people’s strictly egalitarian mindset mean that certain forms of magic have little effect on you. When you use your (action: Call on Ancient Blood) reaction against a divine spell and roll a critical failure on the saving throw against that spell, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("2a6dec40-f5ef-467f-8a72-2906aec9d0fe"), Heritages.Instances.AncientBloodedDwarf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cec1d212-5b27-4cad-875d-eb613d31927e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
