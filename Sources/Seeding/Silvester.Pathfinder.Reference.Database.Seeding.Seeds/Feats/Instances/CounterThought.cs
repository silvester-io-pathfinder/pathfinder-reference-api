using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CounterThought : Template
    {
        public static readonly Guid ID = Guid.Parse("dedd3ab8-6543-46f9-9a83-92e91c182cb6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Counter Thought",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature Casts a Spell that has the mental trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9001610f-b018-4ef8-8b90-3f67bdadf0ab"), Type = TextBlockType.Text, Text = $"When a foe {ToMarkdownLink<Models.Entities.Rule>("Casts a Spell", Rules.Instances.CastASpell.ID)} that has the {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)} trait and you can see its manifestations, you can use your own mental magic to disrupt it. You expend one of your spell slots to counter the triggering creature's casting of a spell with the {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)} trait. You lose your spell slot as if you had cast the triggering spell; this spell slot must be one for which you could cast a spell with the {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)} trait. You then attempt to counteract the triggering spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("729ae3aa-da9a-49a6-88af-f24b54bb92ff"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
