using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TriumphantInspiration : Template
    {
        public static readonly Guid ID = Guid.Parse("bed59cbc-b724-4d82-92d3-5dfa1ccc05a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Triumphant Inspiration",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically hit a foe with a melee weapon Strike or a melee unarmed attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("837070c6-65a3-433b-863d-f772e568ea64"), Type = TextBlockType.Text, Text = "With a triumphant shout, you inspire your allies. You cast a composition cantrip you know that normally takes a single action to cast." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("88397cb9-3890-4cee-abf3-9d423ba871df"), Muses.Instances.Warrior.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d904fb8-b7fe-4855-84b2-500f7a594cfb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
