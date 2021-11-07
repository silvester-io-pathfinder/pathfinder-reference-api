using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ManeuveringSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("b605afce-11eb-44d6-a38e-b31c01731ee0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Maneuvering Spell",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You begin to Cast a Spell that requires at least 2 actions to cast.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cef6c9b2-58b5-4024-a643-84e94b117587"), Type = TextBlockType.Text, Text = "You instantly tap into the magical power of a spell you&#39;re casting to quickly pounce around the battlefield. You (action: Step), (action: Leap), or (action: Stand | Stand / Drop Prone). This action can be before or after you (action: Cast the Spell | Cast a Spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4675c832-2b9c-4123-876a-e6aba79703cc"), Feats.Instances.SixthPillarDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("262b6846-9709-4bb2-a4c3-f57a33ff290b"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
