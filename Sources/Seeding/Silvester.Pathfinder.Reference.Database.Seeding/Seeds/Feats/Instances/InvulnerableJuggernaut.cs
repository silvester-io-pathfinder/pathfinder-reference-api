using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvulnerableJuggernaut : Template
    {
        public static readonly Guid ID = Guid.Parse("ab4ad72a-73fb-4dcb-9f15-77a69c97a099");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invulnerable Juggernaut",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34552db7-dc32-47e4-9e9c-353d296fa42c"), Type = TextBlockType.Text, Text = "~ Access: secure Visitor’s Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("5e70907d-1787-433e-9473-40f779d58197"), Type = TextBlockType.Text, Text = "You are unstoppable, able to shrug off mortal wounds with ease. You gain resistance equal to 3 + your Constitution modifier to all damage, and your resistance from raging resistance increases to 8 + your Constitution modifier." };
            yield return new TextBlock { Id = Guid.Parse("cfb2e0a7-313c-4163-8ec6-7533ed500ece"), Type = TextBlockType.Text, Text = "In addition, if you are reduced to 0 Hit Points, you can end your rage as a reaction to stay at 1 Hit Point. If you do, you become wounded 2 (or increase your wounded condition by 2 if you are already wounded)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11f2ab4d-7cba-4557-93e6-0458cc8ab7e5"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
