using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardCasting : Template
    {
        public static readonly Guid ID = Guid.Parse("6ab6aa97-1b07-4edd-bcec-e08c8049c479");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ward Casting",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a flat check for Steady Spellcasting, but you haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0afbc211-3468-4fc9-961f-616db9718bc7"), Type = TextBlockType.Text, Text = "You carefully ward your spell by drawing from a mantle of magical energy you prepared to protect your casting, increasing your chance of retaining the spell. You reduce the DC of the flat check for (feat: Steady Spellcasting) from 15 to 10." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("456655da-82ea-4f84-ae27-713a9d1ab4f6"), Feats.Instances.SpellmasterDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("b4753a7e-8afa-4cff-93bc-42a8ed14ca63"), Feats.Instances.SteadySpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f32ca97-9fa4-41ed-a083-d93350dc50a0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
