using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnapShot : Template
    {
        public static readonly Guid ID = Guid.Parse("93d9039a-1acf-444b-9da2-a3e2c496e27e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snap Shot",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86578aa5-a11c-4d68-8930-9aa017421510"), Type = TextBlockType.Text, Text = "You’ve learned to react with ranged weapons when a creature is in close quarters. You can use a reaction that normally allows you to make a melee weapon (action: Strike) to instead make a ranged weapon (action: Strike). You must be (action: Striking | Strike) an adjacent target." };
            yield return new TextBlock { Id = Guid.Parse("608a7a4d-31cd-40fc-a57c-401c14d299a9"), Type = TextBlockType.Text, Text = "If necessary for the reaction’s trigger, you treat your ranged weapon as if it had a (trait: reach) of 5 feet. If the reaction has other requirements, such as wielding a specific kind of weapon, Snap Shot doesn’t allow you to ignore them; it allows you only to replace a melee weapon (action: Strike) with a ranged weapon (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c9af9c0-b5a7-4b5e-9c12-02e3cfee5c22"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
