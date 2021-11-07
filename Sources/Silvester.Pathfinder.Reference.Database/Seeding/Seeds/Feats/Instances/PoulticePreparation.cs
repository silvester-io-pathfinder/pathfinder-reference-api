using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PoulticePreparation : Template
    {
        public static readonly Guid ID = Guid.Parse("70e69aca-1e67-496a-aca2-9a07802e5f27");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Poultice Preparation",
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
            yield return new TextBlock { Id = Guid.Parse("6196a03f-60f4-4485-8e4c-c59b886097ce"), Type = TextBlockType.Text, Text = "When you create an herbal elixir, you can prepare it as a poultice instead. A poultice gains the (trait: oil) trait (but remains (trait: alchemical), not (trait: magical)) and loses the (trait: elixir) and (trait: ingested) traits. You can apply a poultice by (action: Interacting | Interact) with one hand. When you apply a poultice, in addition to the item’s normal effects, the recipient can attempt an immediate flat check to recover from a single source of persistent acid, bleed, or fire damage, with the DC reduction from appropriate assistance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5536aab1-7e8f-43dd-a993-e89a612e7de0"), Feats.Instances.HerbalistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19742ec2-0aff-4662-a92f-01dd5d8bba28"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
