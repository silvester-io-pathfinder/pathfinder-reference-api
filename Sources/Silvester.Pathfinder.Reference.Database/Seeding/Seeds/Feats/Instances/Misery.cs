using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Misery : Template
    {
        public static readonly Guid ID = Guid.Parse("1db7dfe1-be8e-49a2-970b-e0fee46afbde");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Misery",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("549c7392-98e4-4e36-a2a1-0c8e1fc3f525"), Type = TextBlockType.Text, Text = "To suffer is to know you’re alive; to make your enemies suffer as greatly as you have eases your suffering." };
            yield return new TextBlock { Id = Guid.Parse("cc158a36-9e97-417a-a9e0-3e3660eb6163"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: You gain persistent damage from a foe." };
            yield return new TextBlock { Id = Guid.Parse("0d5dd398-7c86-420c-8813-e4315a452b33"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: You gain a number of temporary Hit Points equal to your level. They last for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("72dc2589-7f22-4bd6-a2de-0b7f7d4f7f18"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: You can choose not to attempt a flat check to end persistent damage you’re taking. When you cast a damaging spell, you can choose one creature that failed its save or that you hit with your spell attack roll. That target takes persistent damage of the same type the spell dealt, of an amount equal to the highest amount of persistent damage you currently have. You can’t choose a creature that’s already taking persistent damage. Spell: (spell: phantom pain)" };
            yield return new TextBlock { Id = Guid.Parse("d8645f34-8ff9-479a-bc84-b873bfea0fd1"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You take an untyped penalty to any damage you would deal with any spell you cast until you (feat: Settle your Emotions| Settle Emotions). The penalty is –1 per spell level." };
            yield return new TextBlock { Id = Guid.Parse("a859fc72-48f1-486d-b602-91f1df7c2726"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: savor the sting)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cbc7215-491d-44b6-a6c6-d12dddf2fef3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
