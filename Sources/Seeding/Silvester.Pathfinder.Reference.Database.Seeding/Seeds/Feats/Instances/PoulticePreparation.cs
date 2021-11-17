using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PoulticePreparation : Template
    {
        public static readonly Guid ID = Guid.Parse("7ce8568f-8b2c-4b75-b2a1-09f044b9822a");

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
            yield return new TextBlock { Id = Guid.Parse("6cc4f6da-77af-4375-b14c-fbf90f2deb88"), Type = TextBlockType.Text, Text = "When you create an herbal elixir, you can prepare it as a poultice instead. A poultice gains the (trait: oil) trait (but remains (trait: alchemical), not (trait: magical)) and loses the (trait: elixir) and (trait: ingested) traits. You can apply a poultice by (action: Interacting | Interact) with one hand. When you apply a poultice, in addition to the item’s normal effects, the recipient can attempt an immediate flat check to recover from a single source of persistent acid, bleed, or fire damage, with the DC reduction from appropriate assistance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4f163571-472e-45fe-a995-20d95f330029"), Feats.Instances.HerbalistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39340da2-c3a4-448c-80fb-842922c13888"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
