using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FireInTheHole : Template
    {
        public static readonly Guid ID = Guid.Parse("f571e339-5509-4505-b099-d5fc371b4182");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fire in the Hole",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature moves into the hazard's space",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4a3ad37-d4c8-4509-ab55-8b3f6db51852"), Type = TextBlockType.Text, Text = "The hazard explodes, dealing the bombs’ damage and splash damage to the inanimate object. Combine this damage for the purpose of resistances and weaknesses, and this damage ignores an amount of the object’s Hardness equal to your level. Any creatures adjacent to the hazard take the bombs’ splash damage, similarly combined for the purpose of resistances and weaknesses. As a reminder, since you didn’t throw the bombs, (feat: Calculated Splash) and similar effects don’t apply." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9aa3d841-6793-48e4-9a47-86c28f375649"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
