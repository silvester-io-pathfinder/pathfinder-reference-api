using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HardTail : Template
    {
        public static readonly Guid ID = Guid.Parse("10936354-559b-4455-b8ea-79b20f8886dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hard Tail",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44f41ab8-89c0-4ff2-8bfc-fe15bd721b2d"), Type = TextBlockType.Text, Text = "Your tail is much stronger than most, and you can lash out with it with the strength of a whip. You gain a tail unarmed attack that deals 1d6 bludgeoning damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("cca85b21-7665-4481-a4b3-f9b067472fb4"), Heritages.Instances.TailedGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("741b67aa-800e-4a5b-8779-d1c8cca08473"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
