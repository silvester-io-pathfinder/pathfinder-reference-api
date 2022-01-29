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
    public class TitansStature : Template
    {
        public static readonly Guid ID = Guid.Parse("cc9b401f-2225-410c-891d-a1411f72ab95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Titan's Stature",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84868912-a029-4e7e-9dc0-be1103b13b37"), Type = TextBlockType.Text, Text = $"You grow to even greater size. When using {ToMarkdownLink<Models.Entities.Feat>("Giant's Stature", Feats.Instances.GiantsStature.ID)}, you can instead become Huge (increasing your reach by 10 feet if you were Medium or smaller) while you are raging. You have the clumsy 1 condition as long as you are Huge." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("6f7c112b-adda-44bb-9402-2ee6bfc19a01"), Instincts.Instances.GiantInstinct.ID);
            builder.HaveSpecificFeat(Guid.Parse("cb3a4b21-271a-4139-a844-f3836578b56f"), Feats.Instances.GiantsStature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7458aaf4-2a57-484d-a78d-1941092ef892"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("bb0bf31b-df50-4508-9374-3f7f1f22bb59"), Traits.Instances.Instinct.ID);
            builder.Add(Guid.Parse("d4a0e40a-c50a-4609-8bbe-e53d3d03b64f"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("202b62d3-d055-4443-af1b-d98f03fe9379"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac84859c-bf6b-477e-b977-54eb40793913"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
