using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneCamouflage : Template
    {
        public static readonly Guid ID = Guid.Parse("d25b38d3-fca7-4009-97c5-8cfd973aab54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Camouflage",
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
            yield return new TextBlock { Id = Guid.Parse("0c0f902b-40cf-40d5-a85c-fd6d3f902c33"), Type = TextBlockType.Text, Text = "You have developed magical techniques to aid you with stalking your prey. You can cast (spell: blur) and (spell: invisibility) each once per day as 2nd-level arcane innate spells." };
            yield return new TextBlock { Id = Guid.Parse("db77cfef-04b2-4063-a9e5-1db804ea9c51"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("90d6ca25-660c-433c-8e9c-a86ab0b9f20c"), Type = TextBlockType.Text, Text = "~ Enhancement: Your camouflage is more potent. Your (spell: blur) spell now lasts 10 minutes and when you cast (spell: invisibility), you can choose to gain the effects of the 4th-level version of the spell. In addition, you can now cast (spell: blur) and (spell: invisibility) each twice per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("9572414d-d600-464a-81b8-5c52d3a37c0d"), Heritages.Instances.HunterAutomaton.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("edcd1451-2d90-4ff5-ad3c-55d40aca6fb0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
