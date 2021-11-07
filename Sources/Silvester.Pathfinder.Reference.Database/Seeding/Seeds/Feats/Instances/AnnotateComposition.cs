using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnnotateComposition : Template
    {
        public static readonly Guid ID = Guid.Parse("a61e2402-1170-4926-aa82-cdf8140c0fb6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Annotate Composition",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9cb6ba20-7278-43df-bb41-783bc13ebd8a"), Type = TextBlockType.Text, Text = "By putting composition to paper, you can create a source of stirring words or song that others can read and understand. You spend 10 minutes and 1 Focus Point to transpose a composition spell on a special scroll that you or another creature can later activate. This composition spell must take a single action to cast. If the chosen composition spell requires a Performance check as part of the casting, the GM rolls this check as a secret check when you annotate your score. If you have (spell: inspire heroics) or (spell: lingering composition) and the chosen composition spell allows, you can also use one of those spells to modify the annotated composition, with the GM rolling the secret Performance check. If you do, you spend an additional Focus Point, even if the secret check fails." };
            yield return new TextBlock { Id = Guid.Parse("36439017-b580-4bfe-adad-9dbef5482a0c"), Type = TextBlockType.Text, Text = "Any creature that can read the language you used when annotating your composition can Activate the Item by spending a single action, which has the (trait: concentrate) trait. This produces the effects of the composition as though the activating creature had (activity: Cast the Spell | Cast a Spell)." };
            yield return new TextBlock { Id = Guid.Parse("e8d77c60-d90f-461a-90f5-6156dbf631ca"), Type = TextBlockType.Text, Text = "A composition you create this way loses its power the next time you make your daily preparations. While the composition is in your possession, you can render it inert using a single action that has the (trait: concentrate) trait. You can’t regain the Focus Points you spent to create the annotated composition until it is activated or loses its magic." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb976b0c-b127-4e58-b5d1-7586c4403933"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
