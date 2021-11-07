using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemicalDiscoveries : Template
    {
        public static readonly Guid ID = Guid.Parse("1f506309-ce79-4ecd-b084-c704793a3d33");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemical Discoveries",
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
            yield return new TextBlock { Id = Guid.Parse("2216db80-affc-4ca0-a896-2dc862616748"), Type = TextBlockType.Text, Text = "You&#39;ve devoted extra time in the lab to improve your knowledge of alchemy. You learn the formulas for two alchemical items each time you level up instead of one; these must still be elixirs or tools. The number of versatile vials you can create each day increases by 1 if you&#39;re an expert in Crafting, 2 if you&#39;re a master, or 3 if you&#39;re legendary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMethodology(Guid.Parse("05757c25-e2e2-45e7-a916-a4ba41878365"), Methodologies.Instances.AlchemicalSciences.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20044e78-5c72-4136-8981-d8f307facfd6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
