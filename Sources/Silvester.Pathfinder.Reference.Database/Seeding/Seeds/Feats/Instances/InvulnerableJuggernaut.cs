using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvulnerableJuggernaut : Template
    {
        public static readonly Guid ID = Guid.Parse("3c846d3a-e601-4b09-afd5-d6919844dce0");

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
            yield return new TextBlock { Id = Guid.Parse("426dc04a-6e70-48b4-9018-4eb32f61cdaf"), Type = TextBlockType.Text, Text = "~ Access: secure Visitor’s Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("834cd669-fcb9-4584-b80b-c0a5dba92459"), Type = TextBlockType.Text, Text = "You are unstoppable, able to shrug off mortal wounds with ease. You gain resistance equal to 3 + your Constitution modifier to all damage, and your resistance from raging resistance increases to 8 + your Constitution modifier." };
            yield return new TextBlock { Id = Guid.Parse("8a464208-fafd-4569-837d-2ca9259ab41e"), Type = TextBlockType.Text, Text = "In addition, if you are reduced to 0 Hit Points, you can end your rage as a reaction to stay at 1 Hit Point. If you do, you become wounded 2 (or increase your wounded condition by 2 if you are already wounded)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8476920-44b9-4e93-90f1-5cc121418ecb"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
