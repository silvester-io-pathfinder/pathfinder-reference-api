using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Headshot : Template
    {
        public static readonly Guid ID = Guid.Parse("f23181cc-9c8c-4495-80b2-504b12339999");

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
            yield return new TextBlock { Id = Guid.Parse("3ce9a3e3-4be4-4b4c-b9fa-3034cf797861"), Type = TextBlockType.Text, Text = "You attempt to finish your target with a final, well-placed shot. Make a crossbow or firearm (action: Strike). If you've damaged the target within the last minute with the same weapon and you get a critical success on your attack roll, the target must succeed at a Fortitude save against your class DC or die; this is a (trait: death) and (trait: incapacitation) effect. A creature that survives is temporarily immune for 1 day. Creatures with no head (such as dullahans or oozes) are immune to this ability, and creatures with redundant heads (such as ettins) might survive the destruction of a head." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("2eb1049f-afd5-4129-87e7-592a9d0d1d85"), GunslingersWays.Instances.WayOfTheSniper.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df936a78-2751-4d64-bf2e-ee63e1b858d4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
