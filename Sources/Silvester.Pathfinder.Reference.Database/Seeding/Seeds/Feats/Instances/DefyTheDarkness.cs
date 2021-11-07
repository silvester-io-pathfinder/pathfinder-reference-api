using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefyTheDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("0e4fc390-db10-4b40-b759-8a8c046bccf4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defy the Darkness",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0dcdd5c0-db91-44d7-829e-a5f48cb45c13"), Type = TextBlockType.Text, Text = "Using ancient dwarven methods developed to fight enemies wielding magical darkness, you’ve honed your darkvision and sworn not to use such magic yourself. You gain greater darkvision, enabling you to see through magical darkness even if it normally hampers darkvision (such as the darkness created by a 4th-level (spell: darkness) spell). You can’t cast spells with the (trait: darkness) trait, use item activations with the (trait: darkness) trait, or use any other ability with the (trait: darkness) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSense(Guid.Parse("e714e56d-6c43-4630-96c7-e8a36d72d49c"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2da79a4-dd97-4fdb-9d5c-4be5fa472412"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
