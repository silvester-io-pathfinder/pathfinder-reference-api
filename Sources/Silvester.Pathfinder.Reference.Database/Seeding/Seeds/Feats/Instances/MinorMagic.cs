using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MinorMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("31e87232-c14f-4f58-9568-a76eebbda3d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Minor Magic",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("36c3c7b5-8e28-4a4b-99a4-4a63aaa533e8"), Type = TextBlockType.Text, Text = "You’ve dabbled in a variety of tricks, gaining minor magical abilities from a particular tradition. Choose arcane, divine, occult, or primal magic, and gain two cantrips from the common cantrips available to that tradition. Your key spellcasting ability is Charisma, and you’re trained in spell attack rolls and DCs for the tradition of your chosen cantrips." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acea2029-19c3-4223-bccb-e6c95e18bcb7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
