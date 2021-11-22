using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemicalDiscoveries : Template
    {
        public static readonly Guid ID = Guid.Parse("6574f793-f115-4662-b452-3d2f014d3d45");

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
            yield return new TextBlock { Id = Guid.Parse("6e595c80-84e5-454d-ab15-67bcbe96a10b"), Type = TextBlockType.Text, Text = "You've devoted extra time in the lab to improve your knowledge of alchemy. You learn the formulas for two alchemical items each time you level up instead of one; these must still be elixirs or tools. The number of versatile vials you can create each day increases by 1 if you're an expert in Crafting, 2 if you're a master, or 3 if you're legendary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMethodology(Guid.Parse("f4917324-ef1d-4bdd-93cd-4885e54c01b0"), Methodologies.Instances.AlchemicalSciences.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccff9ef5-cc54-4b5b-ad61-ba5d57849c06"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
