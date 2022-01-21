using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnnotateComposition : Template
    {
        public static readonly Guid ID = Guid.Parse("e612814d-708b-4deb-a3e8-12e762f09a87");

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
            yield return new TextBlock { Id = Guid.Parse("721fb15f-9823-41e5-961c-eba52da5930d"), Type = TextBlockType.Text, Text = $"By putting composition to paper, you can create a source of stirring words or song that others can read and understand. You spend 10 minutes and 1 Focus Point to transpose a composition spell on a special scroll that you or another creature can later activate. This composition spell must take a single action to cast. If the chosen composition spell requires a Performance check as part of the casting, the GM rolls this check as a secret check when you annotate your score. If you have {ToMarkdownLink<Models.Entities.Spell>("inspire heroics", Spells.Instances.InspireHeroics.ID)} or {ToMarkdownLink<Models.Entities.Spell>("lingering composition", Spells.Instances.LingeringComposition.ID)} and the chosen composition spell allows, you can also use one of those spells to modify the annotated composition, with the GM rolling the secret Performance check. If you do, you spend an additional Focus Point, even if the secret check fails." };
            yield return new TextBlock { Id = Guid.Parse("a80875d3-84bd-40dc-8cfd-3110c46b3619"), Type = TextBlockType.Text, Text = $"Any creature that can read the language you used when annotating your composition can Activate the Item by spending a single action, which has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait. This produces the effects of the composition as though the activating creature had {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("51e39044-9235-418f-a90c-569f646bfa0c"), Type = TextBlockType.Text, Text = $"A composition you create this way loses its power the next time you make your daily preparations. While the composition is in your possession, you can render it inert using a single action that has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait. You can't regain the Focus Points you spent to create the annotated composition until it is activated or loses its magic." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9538ed4d-99d4-48a6-bffb-81cee5d6516b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
