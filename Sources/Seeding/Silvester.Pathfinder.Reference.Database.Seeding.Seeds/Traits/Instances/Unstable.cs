using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Unstable : Template
    {
        public static readonly Guid ID = Guid.Parse("49abc3c8-f272-4da1-ba6b-4c8133ee2351");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Unstable",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d739f2f-2a64-4043-8361-02b3dc38f598"), Type = TextBlockType.Text, Text = "Unstable actions use experimental applications of your innovation that even you can't fully predict, and that are hazardous to your innovation (and potentially you). When you take an unstable action, attempt a DC 17 flat check immediately after applying its effects. On a failure, the innovation malfunctions in a spectacular (though harmless) fashion, such as a belch of smoke or shower of sparks, and it becomes incapable of being used for further unstable actions. On a critical failure, you also take an amount of fire damage equal to your level. As the innovation's creator, you can spend 10 minutes retuning your innovation and making adjustments to return it to functionality, at which point you can use unstable actions with that innovation again." };
            yield return new TextBlock { Id = Guid.Parse("f8d4d3b9-e0b8-4a4c-8e77-d7b03d680c2f"), Type = TextBlockType.Text, Text = "To take an unstable action, you must be using your innovation (for example, wearing an armor innovation or wielding a weapon innovation). If you have a minion innovation, some unstable actions are taken by the minion instead of you. In these cases, only the minion can take that action, and the minion needs to have been Commanded that turn to take the action. If you critically fail the flat check, the minion takes the damage instead of you." };
            yield return new TextBlock { Id = Guid.Parse("313479b0-a09f-4580-8a9c-33ead63aa8fd"), Type = TextBlockType.Text, Text = "Some actions have an Unstable Function entry, which you can use to add the unstable trait for a bigger benefit. If you're unable to use unstable actions, you can still use the action normally, but you can't use the unstable function." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("993c5632-ab89-4dbe-bf9e-78a05e3daf76"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 236
            };
        }
    }
}
