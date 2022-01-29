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
    public class SustainingSteel : Template
    {
        public static readonly Guid ID = Guid.Parse("c9c10ef8-a479-4140-821c-8fbf7179eae2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sustaining Steel",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You Cast a Spell using a spell slot.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1223d7a-b455-4b19-a805-759b916ac2c6"), Type = TextBlockType.Text, Text = $"You pull magic into your weapon, using its substance to transform the magic into restorative energy. You regain Hit Points equal to double the spell's level and roll to end any persistent negative damage you have." };
            yield return new TextBlock { Id = Guid.Parse("c8a80374-0dbf-4cf5-a79c-16881e182eb4"), Type = TextBlockType.Text, Text = $"If the spell was of the necromancy school, any persistent negative damage you have ends automatically, and you can change the damage type from {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)} to positive if you wish. (Positive damage typically damages only undead or other creatures with negative healing.)" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a6fc6547-9810-454a-bcfd-fa8d406e888f"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("315e6932-9713-4b6b-80ac-f31a0b69e1be"), HybridStudies.Instances.InexorableIron.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("df80c789-6ff2-4995-a57f-40ac82e035b0"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("85155870-5eb4-4b4c-8956-db15b518f6a8"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("169cac99-d480-41df-801e-70d8e29aa524"), Traits.Instances.Magus.ID);
            builder.Add(Guid.Parse("874fc3ec-f64c-42cf-8fcb-b309e1866670"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("123a1352-e674-46dc-867f-90d37d2e0fdd"), Traits.Instances.Positive.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1d90518-da67-4a0d-a310-5a3b7f3d2c8c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
