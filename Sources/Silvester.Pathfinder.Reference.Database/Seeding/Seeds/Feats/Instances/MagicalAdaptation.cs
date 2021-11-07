using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalAdaptation : Template
    {
        public static readonly Guid ID = Guid.Parse("4864a65e-99ab-4230-8981-1e5f24abd404");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Adaptation",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6d0786c-e4d8-4c8a-8f63-71c4c71481b3"), Type = TextBlockType.Text, Text = "When an obstacle bars your path, you pull a trick from your sleeve to overcome it. You can cast (spell: darkvision), (spell: spider climb), and 4th-level (spell: water breathing) as innate primal spells, each once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bd14a0c4-46da-4000-ba76-1901018e248e"), Feats.Instances.HorizonWalkerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1566b880-6014-4868-bd7d-7cb76544f0d4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
