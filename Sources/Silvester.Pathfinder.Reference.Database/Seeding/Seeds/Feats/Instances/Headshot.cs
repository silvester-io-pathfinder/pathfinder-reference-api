using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Headshot : Template
    {
        public static readonly Guid ID = Guid.Parse("58e8e145-ba41-4e9f-b72e-e62adf12c319");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Headshot",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4473d826-3f9b-4b94-8c7b-8e038b79f4ba"), Type = TextBlockType.Text, Text = "You attempt to finish your target with a final, well-placed shot. Make a crossbow or firearm (action: Strike). If you’ve damaged the target within the last minute with the same weapon and you get a critical success on your attack roll, the target must succeed at a Fortitude save against your class DC or die; this is a (trait: death) and (trait: incapacitation) effect. A creature that survives is temporarily immune for 1 day. Creatures with no head (such as dullahans or oozes) are immune to this ability, and creatures with redundant heads (such as ettins) might survive the destruction of a head." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("1676009c-cee0-4b81-8f4d-5bebd27b4046"), GunslingerWays.Instances.WayOfTheSniper.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("576d301a-597a-4961-9b3f-fe777b6ec17b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
