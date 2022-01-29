using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("8adb6d75-c0ed-4045-af81-7dd13bbbc873");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Transformation",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d9820ce1-8f4b-44be-9741-2ac823b52b32"), Type = TextBlockType.Text, Text = $"You transform into a ferocious Large dragon, gaining the effects of 6th-level {ToMarkdownLink<Models.Entities.Spell>("dragon form", Spells.Instances.DragonForm.ID)} except that you use your own AC and attack modifier; you also apply your extra damage from {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)}. The action to {ToMarkdownLink<Models.Entities.Action>("Dismiss", Actions.Instances.Dismiss.ID)} the transformation gains the {ToMarkdownLink<Models.Entities.Trait>("rage", Traits.Instances.Rage.ID)} trait." };
            yield return new TextBlock { Id = Guid.Parse("a9e306e1-235a-4f2f-ab1e-facbc0138c40"), Type = TextBlockType.Text, Text = $"At 18th level, you gain a +20-foot status bonus to your fly Speed, your damage bonus with dragon {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} increases to +12, your breath weapon DC is your class DC, and you gain a +14 status bonus to your breath weapon damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("bc0fbe9d-412f-4467-930a-3bf312bf7a5a"), Instincts.Instances.DragonInstinct.ID);
            builder.HaveSpecificFeat(Guid.Parse("94f76a29-94df-4699-adc2-08a0bbaa44fa"), Feats.Instances.DragonsRageWings.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("232f1421-ffaa-45e7-bf94-a95414fc35b4"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("0b47f904-5dce-47eb-96c8-153c391d07a5"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("3e742d57-fed5-4348-b147-80b6a4c4d0e7"), Traits.Instances.Instinct.ID);
            builder.Add(Guid.Parse("8fc12a87-9d59-481e-95f7-622a247c987c"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("9b7da045-df7a-4f2d-bb43-4f63035fcadf"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("8942b6a0-0990-43fd-b5bf-55c7a549d97b"), Traits.Instances.Rage.ID);
            builder.Add(Guid.Parse("12565e05-dfc1-41cb-bfcb-d21da89a05a9"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d77a31d-395f-4bf2-a830-63796701b0e6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
