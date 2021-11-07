using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Assassinate : Template
    {
        public static readonly Guid ID = Guid.Parse("2f248b0b-77f6-4173-b434-095fa63e28c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assassinate",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9e16734-4e60-4b8a-b31b-d0a9216a033a"), Type = TextBlockType.Text, Text = "You strike with one swift movement, trying to instantly slay your mark. Make a (action: Strike) against your mark. If you hit, your mark takes 6d6 extra precision damage with a basic Fortitude save against your class DC or spell DC, whichever is higher." };
            yield return new TextBlock { Id = Guid.Parse("1e53be27-58da-47e0-8f23-df4292b61fce"), Type = TextBlockType.Text, Text = "If the mark critically fails, they die. This is an (trait: incapacitation) effect. The creature then becomes temporarily immune to your Assassinate for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8b23b337-8555-44a6-bf37-495ce2922c8c"), Feats.Instances.AssasinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8df4d59b-0d88-42e3-bbe6-a3b5207787c2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
